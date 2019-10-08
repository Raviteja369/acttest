<template>
  <div class="home">   
    <FileUploads/>   
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import { AppContainer, TYPES } from "@/app/index";
import FileUploads from "@/components/Product/FileUploads.vue";

@Component({
  components: {
    FileUploads,
  },
})
export default class FileUpload extends Vue {
}
</script>