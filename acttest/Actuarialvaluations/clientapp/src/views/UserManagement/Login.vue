<template>
  <div class="home">   
    <Logins/>   
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import { AppContainer, TYPES } from "@/app/index";
import Logins from "@/components/UserManagement/Logins.vue";

@Component({
  components: {
    Logins,
  },
})
export default class Login extends Vue {
}
</script>