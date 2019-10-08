<template>
  <div class="home">   
    <ChangePasswords/>   
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import { AppContainer, TYPES } from "@/app/index";
import ChangePasswords from "@/components/UserManagement/ChangePasswords.vue";

@Component({
  components: {
    ChangePasswords,
  },
})
export default class ChangePassword extends Vue {
}
</script>