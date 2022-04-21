export class BookModel {

  private _Id?: number | undefined;

  public get Id(): number | undefined {
      return this._Id;
  }

  public set Id(value: number | undefined) {
      this._Id = value;
  }

  private _Title?: string | undefined;

  public get Title(): string | undefined {
      return this._Title;
  }
  public set Title(value: string | undefined) {
      this._Title = value;
  }

  private _ImageId?: number | undefined;

  public get ImageId(): number | undefined {
      return this._ImageId;
  }

  public set ImageId(value: number | undefined) {
      this._ImageId = value;
  }

  private _MaxPages?: number | undefined;

  public get MaxPages(): number | undefined {
      return this._MaxPages;
  }

  public set MaxPages(value: number | undefined) {
      this._MaxPages = value;
  }

  private _CurrentPages?: number | undefined;

  public get CurrentPages(): number | undefined {
      return this._CurrentPages;
  }

  public set CurrentPages(value: number | undefined) {
      this._CurrentPages = value;
  }

  constructor(
    Id?: number,
    Title?: string,
    ImageId?: number,
    MaxPages?: number,
    CurrentPages?: number
  ) {
    this._Id = Id;
    this._Title = Title;
    this._ImageId = ImageId;
    this._MaxPages = MaxPages;
    this._CurrentPages = CurrentPages;
  }


}
