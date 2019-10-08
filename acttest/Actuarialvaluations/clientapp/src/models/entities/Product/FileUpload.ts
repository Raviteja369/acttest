/**
 * The File Upload model class
 */
export class FileUpload {
    public Classification: string = '';
    public TableName: string = "";
    public LocationType: string = "";
    public Type: string = "";
    public Path: string = "";
    
    constructor(data: any = null) {
        if (data) {
            Object.assign(this, data);
        }
    }
}