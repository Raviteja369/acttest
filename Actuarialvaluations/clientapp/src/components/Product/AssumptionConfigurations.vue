<template> 
     <b-container>     <b-card>
    <b-form @submit.stop.prevent="Save">
    <div>
        <h1> Assumption Configuration. </h1>
    </div>  
    <div class="form-row"> 
      <div class="form-group col-md-6">
          <b-form-group  label-cols-sm="10" label-cols-md="3" label-cols-lg="6" breakpoint="md" label="Applicable Assumption Code " label-for="Select the Applicable Assumption Code">
            <b-form-select id="AAC" aria-describedby="AACError" :options= this.modelPointVariableDropDown class="mb-2" value-field = 1>       
            </b-form-select>      
            <b-form-invalid-feedback id="AACError" >Field is required</b-form-invalid-feedback>
          </b-form-group>
     </div>
      <div class="form-group col-md-6">
          <b-button @click="Add"  variant="primary" >Add</b-button>
      </div>  
    </div>
    <div class="form-row"> 
      <div class="form-group col-md-6">
        <h5 class="text-lg-center"> OR </h5>
      </div>  
    </div>
     <div class="form-row">       
        <div class="form-group col-md-6">
               <b-form-group group horizontal :label-cols="6" breakpoint="md" label="1. Add New Assumption Code " label-for="1. Add New Assumption Code">
                <b-form-input autocomplete="off" id="NewAssumptionCode" type="text" aria-describedby="NewAssumptionCodeError" placeholder="Add New Assumption Code"></b-form-input>
                <b-form-invalid-feedback id="NewAssumptionCodeError">Field is required</b-form-invalid-feedback>
            </b-form-group>              
        </div>
    </div>
     <div class="form-row">
      <div class="form-group col-md-6">
          <b-form-group  label-cols-sm="10" label-cols-md="3" label-cols-lg="6" breakpoint="md" label="2. Add Assumption Variable " label-for="2. Add Assumption Variable">
            <b-form-select id="AddAssumptionVariable" aria-describedby="AddAssumptionVariableError" :options= this.assumptionVariableDropDown class="mb-2" value-field = 1>       
            </b-form-select>      
            <b-form-invalid-feedback id="AddAssumptionVariableError" >Field is required</b-form-invalid-feedback>
          </b-form-group>
     </div>
      <div class="form-group col-md-6">
          <b-button @click="Add"  variant="primary" >Add</b-button>
      </div>  
    </div>     
     <div style="padding: 10px"> 
    <b-card>
    
    <h6> Applicable Assumption Variables. </h6>
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
              <a :href="`https://www.goggle.com`">Delete</a>
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
  import { Dropdown, DataSet, FormMode, AssumptionConfiguration, ModelPointVariableDropDown,AssumptionCodeDropDown,AssumptionVariableDropDown } from "@/models";
  import { ConfigService, AssumptionConfigurationService, DropDownService } from "@/services";
  
   @Component({
     components: {      
    },  
  })

export default class AssumptionConfigurations extends Vue {
  private configService: ConfigService = AppContainer.get<ConfigService>(TYPES.Services.ConfigService);
  private dateOptions: any = { format: this.configService.Config.DateFormat };
  private dropDownService: DropDownService = AppContainer.get<DropDownService>(TYPES.Services.DropDownService);
  private assumptionConfigurationService: AssumptionConfigurationService = AppContainer.get<AssumptionConfigurationService>(TYPES.Services.AssumptionConfigurationService);
  private itemsDataSet: DataSet<AssumptionCodeDropDown> = new DataSet();  
  private dataSet: DataSet<AssumptionConfiguration> = new DataSet();
  private assumptionVariableDataSet: DataSet<AssumptionVariableDropDown> = new DataSet();  

private modelPointVariableDropDown: Dropdown[] = [];
private assumptionVariableDropDown: Dropdown[] = [];

private fields: any = {  
    Variable: { label: "Variable", thClass: "text-lg-center", tdClass: "text-lg-center", sortable: true},    
    Review: { label: "Review", thClass: "text-lg-center", tdClass: "text-lg-center", sortable: false}
  };

  public created(): void{
    this.itemsDataSet.Configure((config) => {
      this.assumptionConfigurationService
        .GetRecords<IEntityList<AssumptionCodeDropDown>>(`/GetAssumptionCode`)
        .then((response) => {             
          config.DataLoadedCallback(
            response.data.Entities.map((entity) => new AssumptionCodeDropDown(entity)),
            response.data.Total
          );
          response.data.Entities.forEach((entity) =>{
            this.modelPointVariableDropDown.push({value: entity.Value, text:entity.Text});
          });         
        }).catch((error) => {          
          config.DataLoadFailedCallback();
          toastr.error(error.response.data);
        });
    });  

    this.dataSet.SortOrders.push({FieldName: "Variable", SortDescending: true}); 
       this.dataSet.Configure((config) => {
      this.assumptionConfigurationService
        .GetRecords<IEntityList<AssumptionConfiguration>>(`?${this.dataSet.ToODataQuery()}`)
        .then((response) => {          
          config.DataLoadedCallback(
            response.data.Entities.map((entity) => new AssumptionConfiguration(entity)),
            response.data.Total
          );               
        }).catch((error) => {          
          config.DataLoadFailedCallback();
          toastr.error(error.response.data);
        });
    });

    this.assumptionVariableDataSet.Configure((config) => {
      this.assumptionConfigurationService
        .GetRecords<IEntityList<AssumptionVariableDropDown>>(`/GetAssumptionVariable`)
        .then((response) => {             
          config.DataLoadedCallback(
            response.data.Entities.map((entity) => new AssumptionVariableDropDown(entity)),
            response.data.Total
          );
          response.data.Entities.forEach((entity) =>{
            this.assumptionVariableDropDown.push({value: entity.Value, text:entity.Text});
          });         
        }).catch((error: any) => {          
          config.DataLoadFailedCallback();
          toastr.error(error.response.data);
        });
    });  


    this.dataSet.Load();
    this.itemsDataSet.Load();
    this.assumptionVariableDataSet.Load();
  }

  private SortRecords(ctx: any) {
    this.dataSet.SortOrders = [{FieldName: ctx.sortBy, SortDescending: ctx.sortDesc}];
    this.dataSet.Load();
  }

  public navigateToPost(): any {
   this.$router.push({name: "BenefitStructureConfiguration"})
  }

  public Add(): any {
   alert("Added Successfully");
  } 
}
</script>