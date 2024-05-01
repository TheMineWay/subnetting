import { Translation } from "@/types/i18n/translation.enum";
import setupI18n from "@/i18n/setup.i18n";
import { PageProps } from "@/types/router/page-props.type";
import SubnettingTool from "../../components/tool/subnet/subnetting-tool";

export default async function Home({ params: { locale } }: PageProps) {
  const { t } = await setupI18n(locale, [Translation.COMMON]);
  return (
    <main>
      {t("test")}
      <SubnettingTool />
    </main>
  );
}
