<template>
  <div class="home">   
    <TransitionConfigurations/>   
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import { AppContainer, TYPES } from "@/app/index";
import TransitionConfigurations from "@/components/Product/TransitionConfigurations.vue";

@Component({
  components: {
    TransitionConfigurations,
  },
})
export default class TransitionConfiguration extends Vue {
}
</script>