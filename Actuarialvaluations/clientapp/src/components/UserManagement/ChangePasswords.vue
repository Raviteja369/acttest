<template> 
     <b-container>     <b-card>
    <b-form @submit.stop.prevent="Save">  
    <div class="form-row"> 
      <div class="form-group col-md-6">       
             <b-form-group group horizontal :label-cols="4" breakpoint="md" label="Current Password" label-for="Current Password">
                <b-form-input autocomplete="off" id="CurrentPassword" type="text" aria-describedby="CurrentPasswordError" placeholder="Please enter current password"></b-form-input>
                <b-form-invalid-feedback id="CurrentPasswordError">Field is required</b-form-invalid-feedback>
            </b-form-group>
     </div>     
    </div>
     <div class="form-row"> 
      <div class="form-group col-md-6">       
             <b-form-group group horizontal :label-cols="4" breakpoint="md" label="New Password" label-for="New Password">
                <b-form-input autocomplete="off" id="NewPassword" type="text" aria-describedby="NewPasswordError" placeholder="Please enter new password"></b-form-input>
                <b-form-invalid-feedback id="NewPasswordError">Field is required</b-form-invalid-feedback>
            </b-form-group>     
     </div>     
    </div>
     <div class="form-row"> 
      <div class="form-group col-md-6">       
             <b-form-group group horizontal :label-cols="4" breakpoint="md" label="Confirm Password" label-for="Confirm Password">
                <b-form-input autocomplete="off" id="ConfirmPassword" type="text" aria-describedby="ConfirmPasswordError" placeholder="Please enter confirm password"></b-form-input>
                <b-form-invalid-feedback id="ConfirmPasswordError">Field is required</b-form-invalid-feedback>
            </b-form-group>     
     </div>
    </div>
    <div class="form-row"> 
       <div class="form-group col-md-2">
          <b-button @click="ChangePassword"  variant="primary" >Change Password</b-button>
      </div>  
      <div class="form-group col-md-6">
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

export default class ChangePasswords extends Vue {  
  
  public created(): void{   

  }
  public ChangePassword(): any {
   alert("Successfully changed password.");
   this.$router.push({name: "Login"})
  }
  public Cancel(): any {
   this.$router.push({name: "Product"})
  } 
}
</script>