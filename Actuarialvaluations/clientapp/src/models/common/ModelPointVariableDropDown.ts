/**
 * The Model Point Variable DropDown Model class
 */
export class ModelPointVariableDropDown {
    
    public Value: number | null = null;    
    public Text: string | null = null;    
   
    constructor(data: any = null) {
        if (data) {
            Object.assign(this, data);
        }
    }    
}