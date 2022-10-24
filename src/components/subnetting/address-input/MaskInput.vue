<script lang="ts">
import { Options, Vue } from 'vue-class-component';

@Options({})
export default class MaskInput extends Vue { }
</script>

<template>
    <ui-textfield class="address-form-item" :placeholder="24" maxlength="2" />
</template>


<style lang="scss">
@import './MaskInput.scss';
</style>