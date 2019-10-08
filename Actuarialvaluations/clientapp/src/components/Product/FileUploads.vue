<template> 
     <b-container>     <b-card>
    <b-form @submit.stop.prevent="Save">
    <div>
        <h1> Table Rating Factors.</h1>
    </div>  
    <div class="form-row"> 
      <div class="form-group col-md-6">
          <b-form-group  label-cols-sm="10" label-cols-md="3" label-cols-lg="4" breakpoint="md" label="File Classification" label-for="File Classification">
            <b-form-select id="FileClassification" aria-describedby="FileClassificationError" :options= this.classificationsDropDown class="mb-2" value-field = 1>       
            </b-form-select>      
            <b-form-invalid-feedback id="FileClassificationError" >Field is required</b-form-invalid-feedback>
          </b-form-group>
     </div>     
    </div>
    <div class="form-row"> 
      <div class="form-group col-md-6">
          <b-form-group  label-cols-sm="10" label-cols-md="3" label-cols-lg="4" breakpoint="md" label="Table Name" label-for="Table Name">
            <b-form-select id="TableName" aria-describedby="TableNameError" :options= this.tableNameDropDown class="mb-2" value-field = 1>       
            </b-form-select>      
            <b-form-invalid-feedback id="TableNameError" >Field is required</b-form-invalid-feedback>
          </b-form-group>
     </div>     
    </div>
    <div class="form-row"> 
      <div class="form-group col-md-6">
          <b-form-group  label-cols-sm="10" label-cols-md="3" label-cols-lg="4" breakpoint="md" label="Location Type" label-for="Location Type">
            <b-form-select id="LocationType" aria-describedby="LocationTypeError" :options= this.locationTypeDropDown class="mb-2" value-field = 1>       
            </b-form-select>      
            <b-form-invalid-feedback id="LocationTypeError" >Field is required</b-form-invalid-feedback>
          </b-form-group>
     </div>     
    </div>
    <div class="form-row"> 
      <div class="form-group col-md-6">
          <b-form-group  label-cols-sm="10" label-cols-md="3" label-cols-lg="4" breakpoint="md" label="File Type" label-for="File Type">
            <b-form-select id="FileType" aria-describedby="FileTypeError" :options= this.fileTypeDropDown class="mb-2" value-field = 1>       
            </b-form-select>      
            <b-form-invalid-feedback id="FileTypeError" >Field is required</b-form-invalid-feedback>
          </b-form-group>
     </div>     
    </div>
    <div class="form-row"> 
      <div class="form-group col-md-6">       
             <b-form-group group horizontal :label-cols="4" breakpoint="md" label="File Path" label-for="File Path">
                <b-form-input autocomplete="off" id="FilePath" type="text" aria-describedby="FilePathError" placeholder="File Path"></b-form-input>
                <b-form-invalid-feedback id="FilePathError">Field is required</b-form-invalid-feedback>
            </b-form-group>     
     </div>     
    </div>
    <div class="form-row"> 
       <div class="form-group col-md-6">
          <b-button @click="Add"  variant="primary" >Add</b-button>
      </div>   
    </div>
    
     <div style="padding: 10px"> 
    <b-card>
    
    <h6> Applicable Model Point Variables List. </h6>
    <b-table
          outlined
          striped
          responsive
          hover
          async
          bordered          
          :items="dataSet.Records"
          :busy="dataSet.Loading"
          :fields="fields"
          caption-top
          :current-page="dataSet.Page.CurrentPage"
          :sort-by.sync="dataSet.SortOrders.FieldName"
          :sort-direction="dataSet.SortOrders.sortDescending"
           @sort-changed="SortRecords"
        > 
          <div slot="table-busy" class="text-center text-danger my-2">
            <b-spinner class="align-middle"></b-spinner>
            <strong>Loading...</strong>
          </div>       
           <template slot="Absorbing" slot-scope="row">          
              {{ row.item | absorbing }}             
          </template>
           <template slot="Review">
               <a>Edit</a> | <a :href="`https://www.goggle.com`">Delete</a>
            </template>
        </b-table>
        <b-row>
          <b-col md="12" class="my-3">
            <b-pagination
              :total-rows="dataSet.Page.TotalRecords"
              :per-page="dataSet.Page.RecordsPerPage"
              v-model="dataSet.Page.CurrentPage"
              class="my-0"
              align="center"
              @change="(page) => { dataSet.SetPage(page); }"
            />
          </b-col>
        </b-row>
       
        </b-card>
         </div>
     <div>
      <b-button @click="navigateToPost"  variant="primary" >Upload</b-button>
    </div>
  </b-form></b-card>
</b-container>
  
</template>
<script lang="ts">
  import moment from "moment";
  import * as toastr from "toastr";
  import { required, between, minValue } from "vuelidate/lib/validators";
  import { Component, Prop, Vue, Watch } from "vue-property-decorator";
  import { AppContainer, TYPES } from "@/app/index";
  import { IEntityList } from "@/interfaces";
  import { FormHelper } from "@/helpers";
  import { Dropdown, DataSet, FormMode, ModelPointVariableDropDown, FileUpload } from "@/models";
  import { ConfigService, FileUploadService, DropDownService } from "@/services";
  
   @Component({
     components: {      
    },  
  })

export default class FileUploads extends Vue {
  private configService: ConfigService = AppContainer.get<ConfigService>(TYPES.Services.ConfigService);
  private dateOptions: any = { format: this.configService.Config.DateFormat };
  private dropDownService: DropDownService = AppContainer.get<DropDownService>(TYPES.Services.DropDownService);
  private fileUploadService: FileUploadService = AppContainer.get<FileUploadService>(TYPES.Services.FileUploadService);
  private classificationsDataSet: DataSet<ModelPointVariableDropDown> = new DataSet();  
  private tableNameDataSet: DataSet<ModelPointVariableDropDown> = new DataSet();  
  private locationTypeDataSet: DataSet<ModelPointVariableDropDown> = new DataSet();  
  private fileTypeDataSet: DataSet<ModelPointVariableDropDown> = new DataSet();  
  private dataSet: DataSet<FileUpload> = new DataSet();

private classificationsDropDown: Dropdown[] = [];
private tableNameDropDown: Dropdown[] = [];
private locationTypeDropDown: Dropdown[] = [];
private fileTypeDropDown: Dropdown[] = [];

private fields: any = {  
    Classification: { label: "Classification", tdClass: "text-lg-center", sortable: true},
    TableName: { label: "TableName", tdClass: "text-lg-center", sortable: true},
    LocationType: { label: "Location Type", tdClass: "text-lg-center", sortable: true},
    Type: { label: "File Type", tdClass: "text-lg-center", sortable: true},
    Path: { label: "File Path", tdClass: "text-lg-center", sortable: true},
    Review: { label: "Review", thClass: "text-lg-center", tdClass: "text-lg-center", sortable: false}
  };

  public created(): void{
    this.classificationsDataSet.Configure((config) => {
      this.fileUploadService
        .GetRecords<IEntityList<ModelPointVariableDropDown>>(`/GetClassifications`)
        .then((response) => {             
          config.DataLoadedCallback(
            response.data.Entities.map((entity) => new ModelPointVariableDropDown(entity)),
            response.data.Total
          );
          response.data.Entities.forEach((entity) =>{
            this.classificationsDropDown.push({value: entity.Value, text:entity.Text});
          });         
        }).catch((error) => {          
          config.DataLoadFailedCallback();
          toastr.error(error.response.data);
        });
    });  

this.tableNameDataSet.Configure((config) => {
      this.fileUploadService
        .GetRecords<IEntityList<ModelPointVariableDropDown>>(`/GetTableNames`)
        .then((response) => {             
          config.DataLoadedCallback(
            response.data.Entities.map((entity) => new ModelPointVariableDropDown(entity)),
            response.data.Total
          );
          response.data.Entities.forEach((entity) =>{
            this.tableNameDropDown.push({value: entity.Value, text:entity.Text});
          });         
        }).catch((error) => {          
          config.DataLoadFailedCallback();
          toastr.error(error.response.data);
        });
    });  

    this.locationTypeDataSet.Configure((config) => {
      this.fileUploadService
        .GetRecords<IEntityList<ModelPointVariableDropDown>>(`/GetLocationTypes`)
        .then((response) => {             
          config.DataLoadedCallback(
            response.data.Entities.map((entity) => new ModelPointVariableDropDown(entity)),
            response.data.Total
          );
          response.data.Entities.forEach((entity) =>{
            this.locationTypeDropDown.push({value: entity.Value, text:entity.Text});
          });         
        }).catch((error) => {          
          config.DataLoadFailedCallback();
          toastr.error(error.response.data);
        });
    });  

    this.fileTypeDataSet.Configure((config) => {
      this.fileUploadService
        .GetRecords<IEntityList<ModelPointVariableDropDown>>(`/GetFileTypes`)
        .then((response) => {             
          config.DataLoadedCallback(
            response.data.Entities.map((entity) => new ModelPointVariableDropDown(entity)),
            response.data.Total
          );
          response.data.Entities.forEach((entity) =>{
            this.fileTypeDropDown.push({value: entity.Value, text:entity.Text});
          });         
        }).catch((error) => {          
          config.DataLoadFailedCallback();
          toastr.error(error.response.data);
        });
    });  
    this.dataSet.SortOrders.push({FieldName: "Variable", SortDescending: true}); 
       this.dataSet.Configure((config) => {
      this.fileUploadService
        .GetRecords<IEntityList<FileUpload>>(`?${this.dataSet.ToODataQuery()}`)
        .then((response) => {          
          config.DataLoadedCallback(
            response.data.Entities.map((entity) => new FileUpload(entity)),
            response.data.Total
          );               
        }).catch((error) => {          
          config.DataLoadFailedCallback();
          toastr.error(error.response.data);
        });
    });  

    this.dataSet.Load();
    this.classificationsDataSet.Load();
    this.tableNameDataSet.Load();
    this.locationTypeDataSet.Load();
    this.fileTypeDataSet.Load();

  }

  private SortRecords(ctx: any) {
    this.dataSet.SortOrders = [{FieldName: ctx.sortBy, SortDescending: ctx.sortDesc}];
    this.dataSet.Load();
  }

  public navigateToPost(): any {
   this.$router.push({name: "Product"})
  }

  public Add(): any {
   alert("Added Successfully");
  } 
}
</script>