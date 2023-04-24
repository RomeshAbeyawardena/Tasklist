import { defineStore } from "pinia";
import { Ref, ref } from "vue";
import { IClient } from "../models/client";
import Axios from "axios";
export interface IClientStore {
    cachedClients: Ref<Array<IClient>>;
    getClients(): Promise<Array<IClient>>
}

export const createClientStore = defineStore("client-store", (): IClientStore => {
    const cachedClients = ref(new Array<IClient>());
    async function getClients() {
        return Array<IClient>();
    }

    return {
        cachedClients,
        getClients
    };
});