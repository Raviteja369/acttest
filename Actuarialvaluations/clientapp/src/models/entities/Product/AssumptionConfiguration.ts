/**
 * The Assumption Configuration model class
 */
export class AssumptionConfiguration {
    public Variable: string = '';   

    constructor(data: any = null) {
        if (data) {
            Object.assign(this, data);
        }
    }
}