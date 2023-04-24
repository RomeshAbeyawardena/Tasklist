export interface IEntry {
    client?:string;
    clientId?:number;
    project?:string;
    projectId?:number;
    notes?:string;
}

export class Entry implements IEntry {
    client?:string;
    clientId?:number;
    project?:string;
    projectId?:number;
    notes?:string;

    constructor() {
        this.client = "";
        this.clientId = -1;
        this.notes = "";
        this.project = "";
        this.projectId = -1;
    }
}