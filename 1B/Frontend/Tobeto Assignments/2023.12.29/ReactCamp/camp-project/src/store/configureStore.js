import rootReducer from "./rootReducer";
import { devToolsEnhancer } from "redux-devtools-extension";
import { legacy_createStore as createStore } from "redux";

export function configureStore() {
  return createStore(rootReducer, devToolsEnhancer());
}
