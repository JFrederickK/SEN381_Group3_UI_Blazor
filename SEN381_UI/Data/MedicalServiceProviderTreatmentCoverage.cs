﻿namespace SEN381_UI.Data;

public class MedicalServiceProvidorTreatmentCoverage
{
    string MSPTCID;
    TreatmentCoverage TreatmentCoverage;
    MedicalServiceProvider medicalServiceProvider;
    string MSPTCStatus;

    public MedicalServiceProvidorTreatmentCoverage(string mSPTCID, TreatmentCoverage treatmentCoverage, MedicalServiceProvider medicalServiceProvider, string mSPTCStatus)
    {
        MSPTCID = mSPTCID;
        TreatmentCoverage = treatmentCoverage;
        this.medicalServiceProvider = medicalServiceProvider;
        MSPTCStatus = mSPTCStatus;
    }

    public string MSPTCID1 { get => MSPTCID; set => MSPTCID = value; }
    public TreatmentCoverage TreatmentCoverage1 { get => TreatmentCoverage; set => TreatmentCoverage = value; }
    public MedicalServiceProvider MedicalServiceProvidor { get => medicalServiceProvider; set => medicalServiceProvider = value; }
    public string MSPTCStatus1 { get => MSPTCStatus; set => MSPTCStatus = value; }
}