<template> 
     <b-container>     <b-card>
    <b-form @submit.stop.prevent="Save">  
    <div class="form-row"> 
      <div class="form-group col-md-6">       
             <b-form-group group horizontal :label-cols="3" breakpoint="md" label="User Name *" label-for="User Name">
                <b-form-input autocomplete="off" id="UserName" type="text" aria-describedby="UserNameError" placeholder="Please enter User Name"></b-form-input>
                <b-form-invalid-feedback id="UserNameError">Field is required</b-form-invalid-feedback>
            </b-form-group>
     </div>     
    </div>
     <div class="form-row"> 
      <div class="form-group col-md-6">       
             <b-form-group group horizontal :label-cols="3" breakpoint="md" label="Password *" label-for=" Password">
                <b-form-input autocomplete="off" id="Password" type="password" aria-describedby="PasswordError" placeholder="Please enter password"></b-form-input>
                <b-form-invalid-feedback id="PasswordError">Field is required</b-form-invalid-feedback>
            </b-form-group>     
     </div>     
    </div>   
    <div class="form-row"> 
       <div class="form-group col-md-1">
          <b-button @click="Login"  variant="primary" >Login</b-button>
      </div>  
      <div class="form-group col-md-2">
          <b-button @click="Cancel"  variant="secondary" >Cancel</b-button>
      </div>   
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

   @Component({
     components: {      
    },  
  })

export default class Logins extends Vue {
  
  public created(): void{   

  }
  public Login(): any {
   alert("Successfully Login.");
    this.$router.push({name: "Product"})
  }
  public Cancel(): any {
   this.$router.push({name: "Login"})
  } 
}
</script>