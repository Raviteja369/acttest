import { inject, injectable } from 'inversify';
import { EntityServiceBase } from '@/bases/services/EntityServiceBase';
import { TransitionConfiguration } from '@/models';
import { AxiosPromise } from 'axios';

@injectable()
export class TransitionConfigurationService extends EntityServiceBase<TransitionConfiguration> {
    public constructor() {
        super();
        this.baseUrl = "api/TransitionConfiguration";
    }  
}