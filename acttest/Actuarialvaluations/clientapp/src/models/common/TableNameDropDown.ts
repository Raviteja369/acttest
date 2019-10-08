/**
 * The Rating Factor Dropdown model class
 */
export class TableNameDropDown {
    
    public Value: number | null = null;    
    public Text: string | null = null;    
   
    constructor(data: any = null) {
        if (data) {
            Object.assign(this, data);
        }
    }    
}