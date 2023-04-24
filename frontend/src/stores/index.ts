import { defineStore } from "pinia";
import { Ref, ref } from "vue";
export interface IMainStore {
    isReadOnly: Ref<boolean>;
}

export const createMainStore = defineStore("main-store", () : IMainStore => {
    const isReadOnly = ref(false);
    return {
        isReadOnly
    };
});