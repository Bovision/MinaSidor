import { useTranslation } from "react-i18next";

const DashboardMarknad = () => {
    const { t } = useTranslation("dashboard");
    return (
        <>
            <p className='rubrik'>{t('marketing')}</p>
            <p>Här visas Marknadsföring</p>

        </>
    );
};

export default DashboardMarknad;