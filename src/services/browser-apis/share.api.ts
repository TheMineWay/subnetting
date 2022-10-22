import { IBrowserApi } from "./browser-api.interface";

export class ShareApi implements IBrowserApi {
    isAvailable() {
        return typeof navigator.share === 'function' && navigator.canShare();
    }

    /* eslint-disable-next-line */
    async share(t: (key: string) => string, onShare?: () => void) {
        await navigator.share({
            title: t('messages.share.Title'),
            text: t('messages.share.Text'),
        });
        if (onShare) onShare();
    }
}