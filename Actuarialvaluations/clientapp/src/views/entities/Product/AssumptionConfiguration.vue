<template>
  <div class="home">   
    <AssumptionConfigurations/>   
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import { AppContainer, TYPES } from "@/app/index";
import AssumptionConfigurations from "@/components/Product/AssumptionConfigurations.vue";

@Component({
  components: {
    AssumptionConfigurations,
  },
})
export default class AssumptionConfiguration extends Vue {
}
</script>