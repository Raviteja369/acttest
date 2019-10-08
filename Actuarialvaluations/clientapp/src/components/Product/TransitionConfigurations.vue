<template> 
     <b-container>     <b-card>
    <b-form @submit.stop.prevent="Save">
    <div>
        <h1> Applicable Transition Configuration. </h1>
    </div>  
    <div class="form-row"> 
      <div class="form-group col-md-6">
          <b-form-group  label-cols-sm="10" label-cols-md="3" label-cols-lg="4" breakpoint="md" label="From State *" label-for="MarkovState">
            <b-form-select id="MarkovState" aria-describedby="MarkovStateError" :options= this.markovStateOptions class="mb-2">       
            </b-form-select>      
            <b-form-invalid-feedback id="MarkovStateError" >Field is required</b-form-invalid-feedback>
          </b-form-group>
     </div>
      <div class="form-group col-md-6">
          <b-form-group  label-cols-sm="10" label-cols-md="3" label-cols-lg="4" breakpoint="md" label="To State *" label-for="MarkovState">
            <b-form-select id="MarkovState" aria-describedby="MarkovStateError" :options= this.markovStateOptions class="mb-2">       
            </b-form-select>
            <b-form-invalid-feedback id="MarkovStateError" >Field is required</b-form-invalid-feedback>
          </b-form-group>
       </div>
  </div>

     <div class="form-row"> 
          <div class="form-group col-md-6">
                  <b-form-group label-cols-sm="10" label-cols-md="4" label-cols-lg="4" breakpoint="md" label="Base Table" label-for="Base Table">
                      <b-form-select id="BaseTable"  aria-describedby="BaseTable" class="mb-2">
                        <option value=1> N/A</option>
                        <option value=1>Mort_Base_Acc_Table</option>
                        <option value=1>Mort_Base_Acc_Table</option>
                        <option value=1>Mort_Base_Table</option>
                        <option value=1>Mort_Impro_Table</option>
                        <option value=1>AIDS_Table</option>
                        <option value=1>Disab_Temp_Table</option>
                        <option value=1>Disab_Perm_Table</option>
                        <option value=1>Retr_Table</option>
                        <option value=1>Crit_Ill_Table</option>
                        <option value=1>Mat_Table</option>
                        <option value=1>Lapse_Table</option>
                        <option value=1>Full_Paid_UP_Table</option>
                        <option value=1>Semi_Paid_UP_Table</option>
                      </b-form-select>
                    <b-form-invalid-feedback id="BaseTableError">Field is required</b-form-invalid-feedback>
                  </b-form-group>
        </div>
        <div class="form-group col-md-6">
            <b-form-group label-cols-sm="10" label-cols-md="3" label-cols-lg="4" breakpoint="md" label="Additional Table 1" label-for="Additional Table 1">
                <b-form-select id="AdditionalTable1"  aria-describedby="AdditionalTable1Error" class="mb-2">
                  <option value=1>N/A</option>
                  <option value=2>Mort_Base_Acc_Table</option>
                  <option value=3>Mort_Base_Acc_Table</option>
                  <option value=4>Mort_Base_Table</option>
                  <option value=5>Mort_Impro_Table</option>
                  <option value=16>AIDS_Table</option>
                  <option value=7>Disab_Temp_Table</option>
                  <option value=8>Disab_Perm_Table</option>
                  <option value=9>Retr_Table</option>
                  <option value=10>Crit_Ill_Table</option>
                  <option value=11>Mat_Table</option>
                  <option value=12>Lapse_Table</option>
                  <option value=13>Full_Paid_UP_Table</option>
                  <option value=14>Semi_Paid_UP_Table</option> 
                </b-form-select>
                <b-form-invalid-feedback id="AdditionalTable1Error">Field is required</b-form-invalid-feedback>
              </b-form-group>
        </div>
    </div>

<div class="form-row"> 
          <div class="form-group col-md-6">
                  <b-form-group label-cols-sm="10" label-cols-md="3" label-cols-lg="4" breakpoint="md" label="Additional Table 2" label-for="AdditionalTable2">
                      <b-form-select id="AdditionalTable2"  aria-describedby="AdditionalTable2Eror" class="mb-2">
                        <option value=1>N/A</option>
                        <option value=2>Mort_Base_Acc_Table</option>
                        <option value=3>Mort_Base_Acc_Table</option>
                        <option value=4>Mort_Base_Table</option>
                        <option value=5>Mort_Impro_Table</option>
                        <option value=16>AIDS_Table</option>
                        <option value=7>Disab_Temp_Table</option>
                        <option value=8>Disab_Perm_Table</option>
                        <option value=9>Retr_Table</option>
                        <option value=10>Crit_Ill_Table</option>
                        <option value=11>Mat_Table</option>
                        <option value=12>Lapse_Table</option>
                        <option value=13>Full_Paid_UP_Table</option>
                        <option value=14>Semi_Paid_UP_Table</option> 
                      </b-form-select>
                    <b-form-invalid-feedback id="AdditionalTable2Error">Field is required</b-form-invalid-feedback>
                  </b-form-group>
        </div>
        <div class="form-group col-md-6">
            <b-form-group label-cols-sm="10" label-cols-md="3" label-cols-lg="4" breakpoint="md" label="Additional Table 3" label-for="Additional Table 3">
                <b-form-select id="AdditionalTable3"  aria-describedby="AdditionalTable3Error" class="mb-2">
                <option value=1>N/A</option>
                  <option value=2>Mort_Base_Acc_Table</option>
                  <option value=3>Mort_Base_Acc_Table</option>
                  <option value=4>Mort_Base_Table</option>
                  <option value=5>Mort_Impro_Table</option>
                  <option value=16>AIDS_Table</option>
                  <option value=7>Disab_Temp_Table</option>
                  <option value=8>Disab_Perm_Table</option>
                  <option value=9>Retr_Table</option>
                  <option value=10>Crit_Ill_Table</option>
                  <option value=11>Mat_Table</option>
                  <option value=12>Lapse_Table</option>
                  <option value=13>Full_Paid_UP_Table</option>
                  <option value=14>Semi_Paid_UP_Table</option> 
                </b-form-select>
                <b-form-invalid-feedback id="AdditionalTable3">Field is required</b-form-invalid-feedback>
              </b-form-group>
        </div>
    </div>
    <div class="form-group row">
        <!-- <div class="col-sm-2"></div> -->
        <div class="col-sm-12">
          <div class="form-check">
            <input class="form-check-input" type="checkbox" id="gridCheck1">
            <label class="form-check-label" for="gridCheck1">
              Absorbing
            </label>
          </div>
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
           <template slot="Review" >
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
  import { MarkovStateDropdown, Dropdown, DataSet, FormMode,TransitionConfiguration } from "@/models";
  import {  ConfigService, ProductMarkovStateService, TransitionConfigurationService, DropDownService } from "@/services";
  
   @Component({
     components: {      
    },  
  })

export default class TransitionConfigurations extends Vue {
  private configService: ConfigService = AppContainer.get<ConfigService>(TYPES.Services.ConfigService);
  private dateOptions: any = { format: this.configService.Config.DateFormat };
  private dropDownService: DropDownService = AppContainer.get<DropDownService>(TYPES.Services.DropDownService);
  private productMarkovStateService: ProductMarkovStateService = AppContainer.get<ProductMarkovStateService>(TYPES.Services.ProductMarkovStateService);
  private transitionConfigurationService: TransitionConfigurationService = AppContainer.get<TransitionConfigurationService>(TYPES.Services.TransitionConfigurationService);
  private itemsDataSet: DataSet<MarkovStateDropdown> = new DataSet();
  private dataSet: DataSet<TransitionConfiguration> = new DataSet();

private markovStateOptions: Dropdown[] = [];
private fields: any = {
    TransitionID: {
      label: "Transition ID",
      sortable: false,
      thClass: "text-lg-center",
      tdClass: "text-lg-center"      
    },
    FromState: { label: "From State", sortable: true},
    ToState: { label: "To State", sortable: true },
    BaseTable: { label: "Base Table", tdClass: "text-lg-center" },
    AdditionalTable1:{ label: "Additional Table 1", tdClass: "text-lg-center" },
    AdditionalTable2:{ label: "Additional Table 2", tdClass: "text-lg-center" },
    AdditionalTable3:{ label: "Additional Table 3", tdClass: "text-lg-center" },
    Absorbing:{ label: "Absorbing", tdClass: "text-lg-center" },
    Review: { label: "Review", tdClass: "text-lg-center", sortable: false}
  };

  public created(): void{
    this.itemsDataSet.Configure((config) => {
      this.dropDownService
        .GetRecords<IEntityList<MarkovStateDropdown>>(`/GetMarkovStates`)
        .then((response) => {             
          config.DataLoadedCallback(
            response.data.Entities.map((entity) => new MarkovStateDropdown(entity)),
            response.data.Total
          );
          response.data.Entities.forEach((entity) =>{
            this.markovStateOptions.push({value: entity.StateId, text:entity.StateName});
          });         
        }).catch((error) => {          
          config.DataLoadFailedCallback();
          toastr.error(error.response.data);
        });
    });  

    this.dataSet.SortOrders.push({FieldName: "TransitionID", SortDescending: true});
    // debugger;

       this.dataSet.Configure((config) => {
      this.transitionConfigurationService
        .GetRecords<IEntityList<TransitionConfiguration>>(`?${this.dataSet.ToODataQuery()}`)
        .then((response) => {          
          config.DataLoadedCallback(
            response.data.Entities.map((entity) => new TransitionConfiguration(entity)),
            response.data.Total
          );               
        }).catch((error) => {          
          config.DataLoadFailedCallback();
          toastr.error(error.response.data);
        });
    });  

    this.dataSet.Load();
    this.itemsDataSet.Load();
    console.log(this.dataSet.Records); 
  }

  private SortRecords(ctx: any) {
    this.dataSet.SortOrders = [{FieldName: ctx.sortBy, SortDescending: ctx.sortDesc}];
    this.dataSet.Load();
  }

  public navigateToPost(): any {
   this.$router.push({name: "TableRatingFactor"})
  }

  public Add(): any {
   alert("Added Successfully");
  } 
}
</script>