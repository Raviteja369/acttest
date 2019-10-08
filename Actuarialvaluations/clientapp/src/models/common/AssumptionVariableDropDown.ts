/**
 * The Assumption Variable DropDown model class
 */
export class AssumptionVariableDropDown {
    
    public Value: number | null = null;    
    public Text: string | null = null;    
   
    constructor(data: any = null) {
        if (data) {
            Object.assign(this, data);
        }
    }    
}