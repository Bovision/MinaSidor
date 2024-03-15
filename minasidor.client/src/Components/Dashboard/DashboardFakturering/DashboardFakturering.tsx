import { useTranslation } from "react-i18next";

const DashboardFakturering = () => {
    const { t } = useTranslation("dashboard");
    return (
        <>
            <p className='rubrik'>{t('billing')}</p>
            <p>Här visas Fakturering</p>

        </>
    );
};

export default DashboardFakturering;