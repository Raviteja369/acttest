<template>
  <div class="home">   
    <BenefitStructureConfigurations/>   
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import { AppContainer, TYPES } from "@/app/index";
import BenefitStructureConfigurations from "@/components/Product/BenefitStructureConfigurations.vue";

@Component({
  components: {
    BenefitStructureConfigurations,
  },
})
export default class BenefitStructureConfiguration extends Vue {
}
</script>