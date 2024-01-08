import { createSlice } from "@reduxjs/toolkit";

const cartSlice = createSlice({
  name: "cart",
  initialState: { cartItems: [] },
  reducers: {
    addToCart: (state: any, action) => {
      state.cartItems = [...state.cartItems, action.payload];
    },
  },
});

export const { addToCart } = cartSlice.actions;
export default cartSlice.reducer;
