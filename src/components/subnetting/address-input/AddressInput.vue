<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import AddressPartInput from './AddressPartInput.vue';
import MaskInput from './MaskInput.vue';

@Options({
    components: {
        AddressPartInput,
        MaskInput,
    }
})
export default class AddressInput extends Vue { }
</script>

<template>
    <ui-card>
        <ui-form nowrap item-margin-bottom="16">
            <AddressPartInput placeholder="192" />
            .
            <AddressPartInput placeholder="168" />
            .
            <AddressPartInput placeholder="0" />
            .
            <AddressPartInput placeholder="0" />
            /
            <MaskInput />
        </ui-form>
    </ui-card>
</template>