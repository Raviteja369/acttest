/**
 * The Benefit Structure Configuration model class
 */
export class BenefitStructureConfiguration {
    public Variable: string = '';   

    constructor(data: any = null) {
        if (data) {
            Object.assign(this, data);
        }
    }
}