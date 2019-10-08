import { inject, injectable } from 'inversify';
import { EntityServiceBase } from '@/bases/services/EntityServiceBase';
import { ApplicableModelPointVariable } from '@/models';
import { AxiosPromise } from 'axios';

@injectable()
export class ApplicableModelPointVariableService extends EntityServiceBase<ApplicableModelPointVariable> {
    public constructor() {
        super();
        this.baseUrl = "api/ApplicableModelPointVariables";
    }  
}