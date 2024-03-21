import i18n from "i18next";
import LanguageDetector from "i18next-browser-languagedetector";
import { initReactI18next } from "react-i18next";
// import login from "./json/login.json";
// import navbar from "./json/navbar.json";
import dashboard from "./json/dashboard.json";
import header from './json/header.json'
import userPages from './json/userPages.json'

function customLangHandlar(inputJson, lang) {
  const result = {};
  for (const key in inputJson) {
    if (Object.hasOwnProperty.call(inputJson, key)) {
      result[key] = inputJson[key][lang];
    }
  }
  return result;
}

i18n
  .use(initReactI18next)
  .use(LanguageDetector)
  .init({
    resources: {
      en: {
        // login: customLangHandlar(login, "en"),
        // navbar: customLangHandlar(navbar, "en"),
        dashboard: customLangHandlar(dashboard, "en"),
        header: customLangHandlar(header, "en"),
        userPages: customLangHandlar(userPages, "en"),
      },
      sv: {
        // login: customLangHandlar(login, "sv"),
        // navbar: customLangHandlar(navbar, "sv"),
        dashboard: customLangHandlar(dashboard, "sv"),
        header: customLangHandlar(header, "sv"),
        userPages: customLangHandlar(userPages, "sv"),
      },
    },
    lng: "en", // Default language
    fallbackLng: "en", // Fallback language
    interpolation: {
      escapeValue: false, // React already escapes values
    },
    debug: true,
  });

export default i18n;
