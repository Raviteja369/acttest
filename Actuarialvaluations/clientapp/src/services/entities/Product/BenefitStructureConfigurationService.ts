import { inject, injectable } from 'inversify';
import { EntityServiceBase } from '@/bases/services/EntityServiceBase';
import { BenefitStructureConfiguration } from '@/models';
import { AxiosPromise } from 'axios';

@injectable()
export class BenefitStructureConfigurationService extends EntityServiceBase<BenefitStructureConfiguration> {
    public constructor() {
        super();
        this.baseUrl = "api/BenefitStructureConfiguration";
    }  
}