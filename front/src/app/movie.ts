export class Movie {
    public selecionado: boolean;

    constructor(
        public id: string,
        public titulo: string,
        public ano: number,
        public nota: number,
    ) {
        this.selecionado = false;
    }
}