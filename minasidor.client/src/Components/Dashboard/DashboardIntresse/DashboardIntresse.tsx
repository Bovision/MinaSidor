import { useTranslation } from "react-i18next";

const DashboardIntresse = () => {
    const { t } = useTranslation("dashboard");
    return (
        <>
            <p className='rubrik'>{t('interests')}</p>
            <p>Här visas Intresseanmälningar</p>

        </>
    );
};

export default DashboardIntresse;