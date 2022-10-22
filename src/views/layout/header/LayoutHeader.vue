<script lang="ts">
import { ShareApi } from '@/services/browser-apis/share.api';
import { Options, Vue } from 'vue-class-component';
import './LayoutHeader.scss';
import { openUrl } from '@/services/nav/open-url';

@Options({})
export default class LayoutHeader extends Vue {
    type = 0;
    title = 'Subnetting';
    shareApi = new ShareApi();

    openGitHubUrl() {
        openUrl('https://github.com/TheMineWay/subnetting', true);
    }

    data() {
        return {};
    }
}
</script>

<template>
    <div class="page-top-app-bar">
        <ui-top-app-bar content-selector="#content-main" :type="type" :title="title">
            <template #toolbar="{ toolbarItemClass }">
                <ui-icon-button v-if="shareApi.isAvailable()" :class="toolbarItemClass" icon="share"
                    @click="shareApi.share($t)"></ui-icon-button>
                <ui-icon-button :class="toolbarItemClass" icon="code" @click="openGitHubUrl()"></ui-icon-button>
            </template>
        </ui-top-app-bar>

        <div id="content-main">
            <router-view />
        </div>
    </div>
</template>