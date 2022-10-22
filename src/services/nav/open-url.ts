export function openUrl(url: string, newTab?: boolean) {
    window.open(url, newTab ? '_blank' : undefined);
}