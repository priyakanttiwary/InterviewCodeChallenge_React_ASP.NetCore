import React, { Component } from 'react';
import axios from 'axios';

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = { productList: [], loading: true, categoryList: [], subCategoryList: [] };
    }

    componentDidMount() {
        this.populateCategoryList();
        this.populateSubCategoryList();
        this.populateProductList();   
    }

    

    static renderProductTable(categoryList,subCategoryList,productList) {
        return (
            <div>
                <div class="panel panel-default">
                    <div class="panel-heading">Search Product</div>
                    <div class="panel-body">
                        <div className='container'>
                            <div className='row'>
                                <div className='col-3'>
                                    Category :
                                </div>
                                <div className='col-3'>
                                    <select name="ddlCat" id="ddlCat">
                                        <option value="0">---Select---</option>
                                        {categoryList.map(category =>
                                            <option value={category.id}>{category.name}</option>
                                        )}
                                    </select>
                                </div>
                                <div className='col-3'>
                                    SubCategory :
                                </div>
                                <div className='col-3'>

                                    <select name="ddlSubCat" id="ddlSubCat">
                                        <option value="0">---Select---</option>
                                        {subCategoryList.map(subCategory =>
                                            <option value={subCategory.id}>{subCategory.name}</option>
                                        )}
                                       
                                    </select>
                                </div>
                            </div>

                        </div>

                    </div>
                </div>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr className="grid-heading">
                            <th>Name</th>
                            <th>Quantity</th>
                            <th>Code</th>
                            <th>Price</th>
                            <th>Description</th>
                        </tr>
                    </thead>
                    <tbody>
                        {productList.map(product =>
                            <tr key={product.id}>
                                <td>{product.name}</td>
                                <td>{product.quantity}</td>
                                <td>{product.code}</td>
                                <td>{product.price}</td>
                                <td>{product.description}</td>
                            </tr>
                        )}
                    </tbody>
                </table>
            </div>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Home.renderProductTable(this.state.categoryList, this.state.subCategoryList,this.state.productList);

        return (
            <div>
                <h1 id="tabelLabel" >Product Listing</h1>

                {contents}
            </div>
        );
    }


    async populateProductList() {
        var self = this;
        axios.get('api/Product')
            .then(function (response) {
                // handle success
                console.log(response);
                self.setState({ productList: response.data.list, loading: false });
            })
            .catch(function (error) {
                // handle error
                console.log(error);
            })
            .finally(function () {
                // always executed
            });

    }

    async populateCategoryList() {
        var self = this;
        axios.get('api/Category')
            .then(function (response) {
                // handle success
                console.log(response);
                self.setState({ categoryList: response.data });
            })
            .catch(function (error) {
                // handle error
                console.log(error);
            })
            .finally(function () {
                // always executed
            });

    }

    async populateSubCategoryList() {
        var self = this;
        axios.get('api/SubCategory')
            .then(function (response) {
                // handle success
                console.log(response);
                self.setState({ subCategoryList: response.data });
            })
            .catch(function (error) {
                // handle error
                console.log(error);
            })
            .finally(function () {
                // always executed
            });

    }
}
