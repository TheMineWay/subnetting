import { IBrowserApi } from "./browser-api.interface";

export class ShareApi implements IBrowserApi {
    isAvailable() {
        return typeof navigator.share === 'function' && navigator.canShare();
    }

    async share(onShare?: () => void) {
        await navigator.share({});
        if (onShare) onShare();
    }
}