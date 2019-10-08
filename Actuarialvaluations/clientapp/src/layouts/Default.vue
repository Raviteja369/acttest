<template>
  <div id="app">
   <b-navbar fixed sticky type="light" variant="light">
      <b-container>  
        <b-navbar-nav class="mr-auto"> 
          <b-nav-item :to="{ name: 'Product' }">Product Creation</b-nav-item>
          </b-navbar-nav>       
         <b-navbar-nav class="ml-auto">
          <div  >
            <h4 style="margin-bottom: 0">Actuarial Valuations Portal</h4>            
            <div style="float: right">
              <b-nav-item-dropdown text="Test User">                
                <b-dropdown-item @click="Logout()">Logout</b-dropdown-item>
                <b-dropdown-item @click="ChangePassword()">Change Password</b-dropdown-item>
              </b-nav-item-dropdown>
            </div>
          </div>       
        </b-navbar-nav>
      </b-container>
    </b-navbar>
    <br />
    <!-- <router-view/> -->
  </div>
</template>
<script lang="ts">
  import { Component, Vue, Prop } from "vue-property-decorator";
  import { AppContainer, TYPES } from "@/app/index";
 
 @Component({})
  export default class App extends Vue {

    private isLogin: boolean = false;
    beforeCreate() {
    }

    created() {      
    }

    Logout() {
       this.$router.push({name: "Product"})
    }
    ChangePassword() {
       this.$router.push({name: "ChangePassword"})
    }
  }
</script>

<style lang="scss">

  #app {
    font-family: "Avenir", Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    color: #2c3e50;
  }

  #nav {
    padding: 55px;
    a {
      font-weight: bold;
      color: #2c3e50;
      &.router-link-exact-active {
        color: #42b983;
      }
    }
  }

  .divider {
    width: 5px;
    height: auto;
    display: inline-block;
  }

  /* Override default toastr opacity */
  body #toast-container > div {
    opacity: 1;
  }

  th {
    white-space: nowrap;
  }
</style>
