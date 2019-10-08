<template>
  <div class="home">   
    <ForgotPasswords/>   
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import { AppContainer, TYPES } from "@/app/index";
import ForgotPasswords from "@/components/UserManagement/ForgotPasswords.vue";

@Component({
  components: {
    ForgotPasswords,
  },
})
export default class ForgotPassword extends Vue {
}
</script>