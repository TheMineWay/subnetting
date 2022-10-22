<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import './LayoutHeader.scss';

@Options({})
export default class LayoutHeader extends Vue {
    data() {
        return {
            type: 0,
            title: 'Subnetting',
        };
    }
}
</script>

<template>
    <div class="page-top-app-bar">
        <ui-top-app-bar content-selector="#content-main" :type="type" :title="title">
            <template #toolbar="{ toolbarItemClass }">
                <ui-icon-button :class="toolbarItemClass" icon="share"></ui-icon-button>
                <ui-icon-button :class="toolbarItemClass" icon="code"></ui-icon-button>
            </template>
        </ui-top-app-bar>

        <div id="content-main">
            <router-view />
        </div>
    </div>
</template>