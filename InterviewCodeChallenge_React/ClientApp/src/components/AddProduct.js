import React, { Component } from 'react';
import axios from 'axios';

export class AddProduct extends Component {
    static displayName = AddProduct.name;

    constructor(props) {
        super(props);

        /*this.state = { forecasts: [], loading: true };*/
        this.handleSubmit = this.handleSubmit.bind(this);
        this.handleChange = this.handleChange.bind(this);
        this.state = {

            product: {}
        }
    }

    handleChange = e => {
        this.name = e.target.name;
        this.value = e.target.value;
        if (this.name == "Quantity") {
            this.value = parseInt(this.value);
        } else if (this.name == "Price") {
            this.value = parseFloat(this.value);
        }

        this.setState(prevState => {
            return {
                product: {
                    ...prevState.product,
                    [this.name]: this.value
                }
            }
        });
    };

    handleSubmit = e => {
        e.preventDefault();

        var self = this;
        let productData = this.state.product;
        axios.post('api/Product', productData)
            .then(function (response) {
                console.log(response);
                self.props.history.replace('/');
            })
            .catch(function (error) {
                console.log(error);
            });
    };

    render() {
        return (
            <div>
                <div class="panel panel-default">
                    <div class="panel-heading">Add Product</div>
                    <div class="panel-body">
                      
                        <div className='container'>
                            <div className='row'>
                                <div className='col-4'>
                                    <form onSubmit={this.handleSubmit}>
                                        <div className="form-group">
                                            <label >Product Name</label>
                                            <input type="text" name='Name' value={this.state.product.Name}
                                                onChange={this.handleChange}
                                                className="form-control" id="ProductName" />
                                        </div>
                                        <div className="form-group">
                                            <label >Product Quantity</label>
                                            <input type="text" name='Quantity' value={this.state.product.Quantity}
                                                onChange={this.handleChange} className="form-control" id="ProductQuantity" />
                                        </div>
                                        <div className="form-group">
                                            <label >Product Code</label>
                                            <input type="text" name='Code' value={this.state.product.Code}
                                                onChange={this.handleChange} className="form-control" id="ProductCode" />
                                        </div>
                                        <div className="form-group">
                                            <label >Product Price</label>
                                            <input type="text" name='Price' value={this.state.product.Price}
                                                onChange={this.handleChange} className="form-control" id="ProductPrice" />
                                        </div>
                                        <div className="form-group">
                                            <label >Product Description</label>
                                            <input type="text" name='Description' value={this.state.product.Description}
                                                onChange={this.handleChange} className="form-control" id="ProductDescription" />
                                        </div>
                                        <button type="submit" className="btn btn-primary">Submit</button>
                                    </form>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
           
        );
    }

}
