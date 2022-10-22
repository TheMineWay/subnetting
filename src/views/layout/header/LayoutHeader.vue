<script lang="ts">
import { ShareApi } from '@/services/browser-apis/share.api';
import { Options, Vue } from 'vue-class-component';
import './LayoutHeader.scss';

@Options({})
export default class LayoutHeader extends Vue {
    type = 0;
    title = 'Subnetting';
    shareApi = new ShareApi();

    data() {
        return {};
    }
}
</script>

<template>
    <div class="page-top-app-bar">
        <ui-top-app-bar content-selector="#content-main" :type="type" :title="title">
            <template #toolbar="{ toolbarItemClass }">
                <ui-icon-button v-if="shareApi.isAvailable()" :class="toolbarItemClass" icon="share"></ui-icon-button>
                <ui-icon-button :class="toolbarItemClass" icon="code"></ui-icon-button>
            </template>
        </ui-top-app-bar>

        <div id="content-main">
            <router-view />
        </div>
    </div>
</template>