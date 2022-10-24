<script lang="ts">
import { Options, prop, Vue } from 'vue-class-component';

class Props {
    placeholder = prop<string>({ required: true });
}

@Options({
    props: {
        placeholder: String
    }
})
export default class AddressPartInput extends Vue.with(Props) { }
</script>

<template>
    <ui-textfield class="address-form-item" :placeholder="placeholder" maxlength="3" />
</template>

<style lang="scss">
@import './AddressPartInput.scss';
</style>