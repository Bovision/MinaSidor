import { useTranslation } from "react-i18next";

const DashboardLeads = () => {
    const { t } = useTranslation("dashboard");
    return (
        <>
            <p className='rubrik'>{t('leads')}</p>
            <p>Här visas Leads</p>

        </>
    );
};

export default DashboardLeads;