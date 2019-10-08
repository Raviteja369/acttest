import { inject, injectable } from 'inversify';
import { EntityServiceBase } from '@/bases/services/EntityServiceBase';
import { FileUpload } from '@/models';
import { AxiosPromise } from 'axios';

@injectable()
export class FileUploadService extends EntityServiceBase<FileUpload> {
    public constructor() {
        super();
        this.baseUrl = "api/FileUpload";
    }  
}