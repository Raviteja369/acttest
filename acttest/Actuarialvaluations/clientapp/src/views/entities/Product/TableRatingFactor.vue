<template>
  <div class="home">   
    <TableRatingFactors/>   
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import { AppContainer, TYPES } from "@/app/index";
import TableRatingFactors from "@/components/Product/TableRatingFactors.vue";

@Component({
  components: {
    TableRatingFactors,
  },
})
export default class TableRatingFactor extends Vue {
}
</script>