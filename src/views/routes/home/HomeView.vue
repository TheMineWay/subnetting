<script lang="ts">
import { Options, Vue } from "vue-class-component";
import SubnettingTool from "@/components/subnetting/SubnettingTool.vue";

@Options({
  components: {
    SubnettingTool,
  },
})
export default class HomeView extends Vue { }
</script>

<template>
  <SubnettingTool />
</template>
