"use client";
import { Button } from "evergreen-ui";
import { useTranslation } from "react-i18next";
import { Translation } from "../../../types/i18n/translation.enum";

export default function SubnettingTool() {
  const { t } = useTranslation([Translation.COMMON]);
  return <Button>{t("test")}</Button>;
}
