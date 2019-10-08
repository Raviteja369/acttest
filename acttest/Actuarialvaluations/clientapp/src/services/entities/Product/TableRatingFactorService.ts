import { inject, injectable } from 'inversify';
import { EntityServiceBase } from '@/bases/services/EntityServiceBase';
import { TableRatingFactor } from '@/models';
import { AxiosPromise } from 'axios';

@injectable()
export class TableRatingFactorService extends EntityServiceBase<TableRatingFactor> {
    public constructor() {
        super();
        this.baseUrl = "api/TableRatingFactor";
    }  
}