/**
 * The ApplicableModelPointVariable model class
 */
export class ApplicableModelPointVariable {
    public Variable: string = '';   

    constructor(data: any = null) {
        if (data) {
            Object.assign(this, data);
        }
    }
}