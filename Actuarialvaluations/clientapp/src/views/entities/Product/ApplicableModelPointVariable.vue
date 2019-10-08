<template>
  <div class="home">   
    <ApplicableModelPointVariables/>   
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import { AppContainer, TYPES } from "@/app/index";
import ApplicableModelPointVariables from "@/components/Product/ApplicableModelPointVariables.vue";

@Component({
  components: {
    ApplicableModelPointVariables,
  },
})
export default class ApplicableModelPointVariable extends Vue {
}
</script>