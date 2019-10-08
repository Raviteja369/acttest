import { inject, injectable } from 'inversify';
import { EntityServiceBase } from '@/bases/services/EntityServiceBase';
import { AssumptionConfiguration } from '@/models';
import { AxiosPromise } from 'axios';

@injectable()
export class AssumptionConfigurationService extends EntityServiceBase<AssumptionConfiguration> {
    public constructor() {
        super();
        this.baseUrl = "api/AssumptionConfiguration";
    }  
}