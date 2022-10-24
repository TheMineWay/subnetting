<script lang="ts">
import { Vue, Options } from 'vue-class-component';
import AddressInput from './address-input/AddressInput.vue';

@Options({
    components: {
        AddressInput,
    }
})
export default class SubnettingTool extends Vue {

}
</script>

<template>
    <AddressInput />
</template>