/**
 * The TableRatingFactor model class
 */
export class TableRatingFactor {
    public TableRatingFactorsID: string = '';
    public TableName: string = "";
    public RatingFactor1: string = "";
    public Dimension1: string = "";
    public RatingFactor2: string = "";
    public Dimension2: string = "";
    public RatingFactor3: string = "";
    public Dimension3: string = "";
    public RatingFactor4: string = "";
    public Dimension4: string = "";

    constructor(data: any = null) {
        if (data) {
            Object.assign(this, data);
        }
    }
}