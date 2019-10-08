<template>
  <div id="app">
   <b-navbar fixed sticky type="light" variant="light">
      <b-container>
         <b-navbar-nav class="ml-auto"> 
              <h4>Actuarial Valuations Portal</h4> 
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
