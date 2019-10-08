const TYPES = {
    Services: {
        // Core Services
        ConfigService: Symbol("ConfigService"),
        
        // Entity Services
        YieldService: Symbol("YieldService"),
        ModelsService: Symbol("ModelsService"),       
        ModelPointsService: Symbol("ModelPointsService"),        
        BenefitsService: Symbol("BenefitsService"),
        MarkovRateInputValuesService: Symbol("MarkovRateInputValuesService"),
        MarkovStatesService: Symbol("MarkovStatesService"),
        ProductService: Symbol("ProductService"),
        

        // Entity / Product 
        ProductMarkovStateService: Symbol("ProductMarkovStateService"),
        TransitionConfigurationService: Symbol("TransitionConfigurationService"),
        TableRatingFactorService: Symbol("TableRatingFactorService"),
        ApplicableModelPointVariableService: Symbol("ApplicableModelPointVariableService"),
        AssumptionConfigurationService: Symbol("AssumptionConfigurationService"),
        BenefitStructureConfigurationService: Symbol("BenefitStructureConfigurationService"),
        FileUploadService: Symbol("FileUploadService"),
        
        // Common Service
        DropDownService: Symbol("DropDownService"),
        
    }
};

export { TYPES };