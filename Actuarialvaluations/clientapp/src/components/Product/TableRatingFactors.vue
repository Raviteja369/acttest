<template> 
     <b-container>     <b-card>
    <b-form @submit.stop.prevent="Save">
    <div>
        <h1> ApplicableTable Rating Factor.</h1>
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
          <b-form-group  label-cols-sm="10" label-cols-md="3" label-cols-lg="4" breakpoint="md" label="Rating Factor 1" label-for="Rating Factor 1">
            <b-form-select id="RatingFactor1" aria-describedby="RatingFactor1Error" :options= this.ratingFactorDropDown class="mb-2" value-field = -1>       
            </b-form-select>
            <b-form-invalid-feedback id="RatingFactor1Error" >Field is required</b-form-invalid-feedback>
          </b-form-group>
       </div>
          <div class="form-group col-md-6">
               <b-form-group group horizontal :label-cols="3" breakpoint="md" label="Dimension" label-for="Dimension 1">
                <b-form-input autocomplete="off" id="Dimension1" type="text" aria-describedby="Dimension1Error" placeholder="Dimension 1"></b-form-input>
                <b-form-invalid-feedback id="Dimension1Error">Field is required</b-form-invalid-feedback>
            </b-form-group>              
        </div>
    </div>

    <div class="form-row"> 
        <div class="form-group col-md-6">
          <b-form-group  label-cols-sm="10" label-cols-md="3" label-cols-lg="4" breakpoint="md" label="Rating Factor 2" label-for="Rating Factor 2">
            <b-form-select id="RatingFactor2" aria-describedby="RatingFactor2Error" :options= this.ratingFactorDropDown class="mb-2" value-field = -1>       
            </b-form-select>
            <b-form-invalid-feedback id="RatingFactor2Error" >Field is required</b-form-invalid-feedback>
          </b-form-group>
       </div>
        <div class="form-group col-md-6">
               <b-form-group group horizontal :label-cols="3" breakpoint="md" label="Dimension" label-for="Dimension 2">
                <b-form-input autocomplete="off" id="Dimension2" type="text" aria-describedby="Dimension2Error" placeholder="Dimension 2"></b-form-input>
                <b-form-invalid-feedback id="Dimension2Error">Field is required</b-form-invalid-feedback>
            </b-form-group>              
        </div>
    </div>
    <div class="form-row"> 
        <div class="form-group col-md-6">
          <b-form-group  label-cols-sm="10" label-cols-md="3" label-cols-lg="4" breakpoint="md" label="Rating Factor 3" label-for="Rating Factor 3">
            <b-form-select id="RatingFactor3" aria-describedby="RatingFactor3Error" :options= this.ratingFactorDropDown class="mb-2" value-field = -1>       
            </b-form-select>
            <b-form-invalid-feedback id="RatingFactor3Error" >Field is required</b-form-invalid-feedback>
          </b-form-group>
       </div>
        <div class="form-group col-md-6">
               <b-form-group group horizontal :label-cols="3" breakpoint="md" label="Dimension" label-for="Dimension 3">
                <b-form-input autocomplete="off" id="Dimension3" type="text" aria-describedby="Dimension4Error" placeholder="Dimension 3"></b-form-input>
                <b-form-invalid-feedback id="Dimension3Error">Field is required</b-form-invalid-feedback>
            </b-form-group>              
        </div>
    </div>

    <div class="form-row"> 
        <div class="form-group col-md-6">
          <b-form-group  label-cols-sm="10" label-cols-md="3" label-cols-lg="4" breakpoint="md" label="Rating Factor 4" label-for="Rating Factor 4">
            <b-form-select id="RatingFactor4" aria-describedby="RatingFactor4Error" :options= this.ratingFactorDropDown class="mb-2" value-field = -1>       
            </b-form-select>
            <b-form-invalid-feedback id="RatingFactor4Error" >Field is required</b-form-invalid-feedback>
          </b-form-group>
       </div>
        <div class="form-group col-md-6">
            <b-form-group group horizontal :label-cols="3" breakpoint="md" label="Dimension" label-for="Dimension 4">
                <b-form-input autocomplete="off" id="Dimension4" type="text" aria-describedby="Dimension4Error" placeholder="Dimension 4"></b-form-input>
                <b-form-invalid-feedback id="Dimension4Error">Field is required</b-form-invalid-feedback>
            </b-form-group>           
        </div>
    </div>   
     <div>
      <b-button @click="Add"  variant="primary" >Add</b-button>
    </div>
     <div style="padding: 10px"> 
    <b-card>
    
       <h5> List Transition Configuration. </h5>
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
              <!-- <b-button size="sm" class="mr-2">Edit</b-button> @click.stop="ViewItemInformation(row.item)"  
              <b-button size="sm" class="mr-2">Delete</b-button>  -->              
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
      <b-button @click="navigateToPost"  variant="primary" >Next</b-button>
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
  import { RatingFactorDropDown, Dropdown, DataSet, FormMode, TableRatingFactor, TableNameDropDown } from "@/models";
  import { ConfigService, TableRatingFactorService, DropDownService } from "@/services";
  
   @Component({
     components: {      
    },  
  })

export default class TableRatingFactors extends Vue {
  private configService: ConfigService = AppContainer.get<ConfigService>(TYPES.Services.ConfigService);
  private dateOptions: any = { format: this.configService.Config.DateFormat };
  private dropDownService: DropDownService = AppContainer.get<DropDownService>(TYPES.Services.DropDownService);
  private tableRatingFactorService: TableRatingFactorService = AppContainer.get<TableRatingFactorService>(TYPES.Services.TableRatingFactorService);
  private itemsDataSet: DataSet<RatingFactorDropDown> = new DataSet();
  private tableNameDataSet: DataSet<TableNameDropDown> = new DataSet();
  private dataSet: DataSet<TableRatingFactor> = new DataSet();

private ratingFactorDropDown: Dropdown[] = [];
private tableNameDropDown: Dropdown[] = [];
private fields: any = {
    // TableRatingFactorsID: { label: "TableRating Factors ID", sortable: false, thClass: "text-lg-center", tdClass: "text-lg-center" },
    TableName: { label: "Table Name", sortable: true},
    RatingFactor1: { label: "Rating Factor 1", tdClass: "text-lg-center" ,sortable: true },
    Dimension1: { label: "Dimension 1", tdClass: "text-lg-left" },
    RatingFactor2:{ label: "Rating Factor 2", tdClass: "text-lg-center" },
    Dimension2:{ label: "Dimension 2", tdClass: "text-lg-left" },
    RatingFactor3:{ label: "Rating Factor 3", tdClass: "text-lg-center" },
    Dimension3:{ label: "Dimension 3", tdClass: "text-lg-left" },
    RatingFactor4: { label: "Rating Factor 4", tdClass: "text-lg-center", sortable: false},
    Dimension4:{ label: "Dimension 4", tdClass: "text-lg-left" },
    Review: { label: "Review", tdClass: "text-lg-center", sortable: false}
  };

  public created(): void{
    this.itemsDataSet.Configure((config) => {
      this.tableRatingFactorService
        .GetRecords<IEntityList<RatingFactorDropDown>>(`/GetRefactors`)
        .then((response) => {             
          config.DataLoadedCallback(
            response.data.Entities.map((entity) => new RatingFactorDropDown(entity)),
            response.data.Total
          );
          response.data.Entities.forEach((entity) =>{
            this.ratingFactorDropDown.push({value: entity.Value, text:entity.Text});
          });         
        }).catch((error) => {          
          config.DataLoadFailedCallback();
          toastr.error(error.response.data);
        });
    });  

this.tableNameDataSet.Configure((config) => {
      this.tableRatingFactorService
        .GetRecords<IEntityList<TableNameDropDown>>(`/GetTableName`)
        .then((response) => {             
          config.DataLoadedCallback(
            response.data.Entities.map((entity) => new TableNameDropDown(entity)),
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

    this.dataSet.SortOrders.push({FieldName: "TableRatingFactorsID", SortDescending: true});
    // debugger;

       this.dataSet.Configure((config) => {
      this.tableRatingFactorService
        .GetRecords<IEntityList<TableRatingFactor>>(`?${this.dataSet.ToODataQuery()}`)
        .then((response) => {          
          config.DataLoadedCallback(
            response.data.Entities.map((entity) => new TableRatingFactor(entity)),
            response.data.Total
          );               
        }).catch((error) => {          
          config.DataLoadFailedCallback();
          toastr.error(error.response.data);
        });
    });  

    this.dataSet.Load();
    this.itemsDataSet.Load();
    this.tableNameDataSet.Load();
    console.log(this.dataSet.Records); 
  }

  private SortRecords(ctx: any) {
    this.dataSet.SortOrders = [{FieldName: ctx.sortBy, SortDescending: ctx.sortDesc}];
    this.dataSet.Load();
  }

  public navigateToPost(): any {
   this.$router.push({name: "ApplicableModelPointVariable"})
  }

  public Add(): any {
   alert("Added Successfully");
  } 
}
</script>