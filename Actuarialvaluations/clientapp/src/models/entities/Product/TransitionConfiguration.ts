/**
 * The MarkovStates model class
 */
export class TransitionConfiguration {
    public TransitionID: string = '';
    public FromState: string = "";
    public ToState: string = "";
    public BaseTable: string = "";
    public AdditionalTable1: string = "";
    public AdditionalTable2: string = "";
    public AdditionalTable3: string = "";
    public Absorbing: boolean | null = false;

    constructor(data: any = null) {
        if (data) {
            Object.assign(this, data);
        }
    }
}