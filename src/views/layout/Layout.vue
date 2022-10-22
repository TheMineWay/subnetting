<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import LayoutHeader from './header/LayoutHeader.vue';

@Options({
    components: {
        LayoutHeader
    }
})
export default class Layout extends Vue { }
</script>

<template>
    <LayoutHeader />
</template>